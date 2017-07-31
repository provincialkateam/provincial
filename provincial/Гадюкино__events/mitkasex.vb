gs'stat'
if mitkaforestsex = 3:
    *clr & cla
	minut += 5
	mitkaforestsex = 0
	dom -= 1
	gang += 1
	boyAsex = 0
	boyBsex = 0
	boyCsex = 0
	boyAsexa = 0
	boyBsexa = 0
	boyCsexa = 0
	dirty_dickA = 0
	dirty_dickB = 0
	dirty_dickC = 0
	mitboysex = 0
	lubonus = 0
	!сколько действий будет длиться секс
	mitboysexrand = rand(1,5)
	!делала ли Мира клизму
	Mira_enema = rand (0,1)
    hantsexa = rand(1,3)
    if $loc = 'gadukino':gs 'gadukino_event', 'onlooker'
    gs'stat'
	'<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsex3.jpg"></center>'
    'Войдя поглубже в заросли парни подошли к вам с Мирой вплотную и начали раздевать. Они надавили вам на плечи и вы принялись...'
    if hantsexa = 1:act 'Сосать':dynamic $mitkaforestsexOral3_1
    if hantsexa = 2:act 'Сосать':dynamic $mitkaforestsexOral3_2
    if hantsexa = 3:act 'Сосать':dynamic $mitkaforestsexOral3_3
end
if mitkaforestsex = 2:
    *clr & cla
    boyAsex = 0
    boyBsex = 0
	dirty_dickA = 0
	dirty_dickB = 0
	boyAsexa = 0
	boyBsexa = 0
	minut += 5
	mitkaforestsex = 0
	dom -= 1
	gang += 1
	lubonus = 0
	temp = rand(1,2)
	if mitboyrand = 1:
	    if temp = 1:$boy = 'Митька' & silavag = 0 & dick = 16
	    if temp = 2:$boy = 'Колямба' & silavag = 0 & dick = 15
	elseif mitboyrand = 2:
	    if temp = 1:$boy = 'Митька' & silavag = 0 & dick = 16
	    if temp = 2:$boy = 'Васян' & silavag = 0 & dick = 14
	elseif mitboyrand = 3:
	    if temp = 1:$boy = 'Колямба' & silavag = 0 & dick = 15
	    if temp = 2:$boy = 'Васян' & silavag = 0 & dick = 14
	end
    horny_boyA = rand(0,90)
	horny_boyB = rand(0,90)
	if $loc = 'gadukino':gs 'gadukino_event', 'onlooker'
    gs'stat'
	'<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsex2.jpg"></center>'
    'Войдя поглубже в заросли парни подошли к вам  с Мирой вплотную и начали раздевать. Они надавили вам на плечи и вы принялись...'
    act 'Сосать':dynamic $mitkaforestsexOral2_1
end
if mitkaforestsex = 1:
    *clr & cla
	minut += 5
	boyAsex = 0
	dirty_dickA = 0
	boyAsexa = 0
	mitkaforestsex = 0
	dom -= 1
	bj += 1
	lubonus = 0
	if mitboyrand = 1:$boy = 'Митька' & silavag = 0 & dick = 16
	if mitboyrand = 2:$boy = 'Колямба' & silavag = 0 & dick = 15
	if mitboyrand = 3:$boy = 'Васян' & silavag = 0 & dick = 14
    horny_boyA = rand(0,90)
    if $loc = 'gadukino':gs 'gadukino_event', 'onlooker'
    gs'stat'
	'<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsex1.'+rand(1,2)+'.jpg"></center>'
    'Войдя поглубже в заросли <<$boy>> подошел к вам с Мирой вплотную и сказал раздеваться раздевать. Потом надавил вам на плечи и вы принялись...'
    hantsexa = rand(1,3)
    if hantsexa = 1:act 'Сосать':dynamic $mitkaforestsexOral1_1
    if hantsexa = 2:act 'Сосать':dynamic $mitkaforestsexOral1_2
    if hantsexa = 3:act 'Сосать':dynamic $mitkaforestsexOral1_3
end
if mitkagadsex = 1:
    *clr & cla
	minut += 5
	boyAsex = 0
	boyAsexa = 0
	dirty_dickA = 0
	mitkaforestsex = 0
	dom -= 1
	bj += 1
	lubonus = 0
	if mitboyrand = 1:$boy = 'Митька' & silavag = 0 & dick = 16
	if mitboyrand = 2:$boy = 'Колямба' & silavag = 0 & dick = 15
	if mitboyrand = 3:$boy = 'Васян' & silavag = 0 & dick = 14
    horny_boyA = rand(0,90)
    if $loc = 'gadukino':gs 'gadukino_event', 'onlooker'
    gs'stat'
	if horny < 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsex1.1.jpg"></center>'
	if horny >= 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsex1.2.jpg"></center>'
    '<<$boy>> отвел вас подальше, на какой-то пустырь, и начал раздевать. Потом надавил вам на плечи и вы принялись...'
    act 'Сосать':dynamic $mitkagadsexOral1
end
if mitkagadsex = 2:
    *clr & cla
    boyAsex = 0
    boyBsex = 0
	boyAsexa = 0
	boyBsexa = 0
	dirty_dickA = 0
	dirty_dickB = 0
	minut += 5
	mitkaforestsex = 0
	dom -= 1
	bj += 2
	gang += 1
	lubonus = 0
	temp = rand(1,2)
	if mitboyrand = 1:
	    if temp = 1:$boy = 'Митька' & silavag = 0 & dick = 16
	    if temp = 2:$boy = 'Колямба' & silavag = 0 & dick = 15
	elseif mitboyrand = 2:
	    if temp = 1:$boy = 'Митька' & silavag = 0 & dick = 16
	    if temp = 2:$boy = 'Васян' & silavag = 0 & dick = 14
	elseif mitboyrand = 3:
	    if temp = 1:$boy = 'Колямба' & silavag = 0 & dick = 15
	    if temp = 2:$boy = 'Васян' & silavag = 0 & dick = 14
	end
    horny_boyA = rand(0,90)
	horny_boyB = rand(0,90)
	if $loc = 'gadukino':gs 'gadukino_event', 'onlooker'
    gs'stat'
	if horny < 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsex2.1.jpg"></center>'
	if horny >= 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsex2.2.jpg"></center>'
    'Парни отвели вас на какой-то пустырь, опустили на колени, и вручив вам в руки свои члены, сказали...'
    act 'Сосать':dynamic $mitkagadsexOral2
end
! Два парня vs ГГ
$mitkagadsexOral2 = {
    *clr & cla
    minut += 5
    horny += 5
    lubonus += 1
    hantsexa = rand(1,3)
    if throat <= 15:horny_boyA += 5 & horny_boyB += 5
    if throat > 15:horny_boyA += 10 & horny_boyB += 10
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexOral2.'+rand(1,2)+'.jpg"></center>'
    'Вы стоите на коленях перед парнями. Они достав свой члены, подносит их к вашим губам...'
    if temp = 1:
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
    elseif temp = 2:
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
    elseif temp = 3:
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
    end
    ''
    '<<$textsexhanter7>>'
    if horny_boyA < 100 and horny_boyB < 100:
        if hantsexa = 1:act 'Нагнуться':dynamic $mitkagadsexStan2
        if hantsexa = 2:act 'Сесть свеху':dynamic $mitkagadsexCow2
        if hantsexa = 3:act 'Стать раком':dynamic $mitkagadsexDog2
    elseif horny_boyA < 100 and horny_boyB >= 100:
        act 'Сосать дальше':dynamic $mitkagadsexOralCum2_2
    elseif horny_boyA >= 100 and horny_boyB < 100:
        act 'Сосать дальше':dynamic $mitkagadsexOralCum2_1
    elseif horny_boyA >= 100 and horny_boyB >= 100:
        act 'Лечь на землю':dynamic $mitkagadsexHandsCum2
    end
}
$mitkagadsexOralCum2_1 = {
    *clr & cla
    minut += 5
    protect = 0
    if temp = 1:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 2:$boy = 'Васян' & silavag = 0 & dick = 14
    if temp = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexOralCum2_1.jpg"></center>'
    'Понимая, что <<$boy>> скоро кончит, вы наращиваете темп, активнее действуя губами и языком...'
    gs 'zz_dynamic_sex', 'swallow'
    ''
    '<<$textsexhanter6>>'
    if temp = 1:$boy = 'Колямба' & silavag = 0 & dick = 15
    if temp = 2:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 3:$boy = 'Васян' & silavag = 0 & dick = 14
    ''
    hantsexa = rand(1,6)
    if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
    if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
    if hantsexa = 3:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
    if hantsexa = 4:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
    if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogVag1
    if hantsexa = 6:act 'Стать раком':dynamic $mitkagadsexDogAnal1
}
$mitkagadsexOralCum2_2 = {
    *clr & cla
    minut += 5
    if temp = 1:$boy = 'Колямба' & silavag = 0 & dick = 15
    if temp = 2:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 3:$boy = 'Васян' & silavag = 0 & dick = 14
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexOralCum2_2.jpg"></center>'
    'Понимая, что <<$boy>> скоро кончит, вы наращиваете темп, активнее действуя губами и языком...'
    gs 'zz_dynamic_sex', 'swallow'
    ''
    '<<$textsexhanter6>>'
    if temp = 1:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 2:$boy = 'Васян' & silavag = 0 & dick = 14
    if temp = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
    ''
    hantsexa = rand(1,6)
    if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
    if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
    if hantsexa = 3:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
    if hantsexa = 4:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
    if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogVag1
    if hantsexa = 6:act 'Стать раком':dynamic $mitkagadsexDogAnal1
}
$mitkagadsexHandsCum2 = {
    *clr & cla
    minut += 5
    hj += 1
    gs 'zz_funcs', 'cum', 'belly'
    protect = 0
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexHandsCum2.'+rand(1,2)+'.jpg"></center>'
    'Вы лежите на земле. Парни, чувствуя приближающийся оргазм, вложили вам в ладошки свой члены, и сказали дрочить. Вы принялись за работу и вскоре были вознаграждены за свое усердие, они застонали и вы почувствовали как выше тело орашают горячие капли спермы.'
    if kosmetica <= 0:'Кончив парни ушли по своим делам. А вы остались приводить себя в порядок.'
    if kosmetica > 0:
        act 'Далее':
            *clr & cla
            minut += 5
            body_write = 1
            kosmetica -= 1
            gs'stat'
            '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexHandsCum2.3.jpg"></center>'
            'Кончив, парни нарисовали на вашем теле "хуй" вашей же помадой, и написав еще пару похабных словечек, ушли по своим делам. А вы остались приводить себя в порядок.'
            act 'Далее':gt $loc, $metka
        end
    else
        act 'Далее':gt $loc, $metka
    end
}
$mitkagadsexDog2 = {
    *clr & cla
    minut += 5
    if boyBsex = 0: boyBsex = 1 & sex += 1
    hantsexa = rand(1,2)
    if throat <= 25:horny_boyA += 5
    if throat > 25:horny_boyA += 10
    if vagina <= 25:horny_boyB += 20
    if vagina > 25:horny_boyB += 10
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexDog2.'+rand(1,3)+'.jpg"></center>'
    'Вы стоите раком перед парнями. Один пристраивается сзади к вашей киске, второй поднес член к вашим губам...'
    if temp = 1:
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'sex_start', 1
        gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    elseif temp = 2:
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'sex_start', 1
        gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    elseif temp = 3:
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'sex_start', 1
        gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    end
    ''
    '<<$textsexhanter7>>'
    if horny_boyA < 100 and horny_boyB < 100:
        if hantsexa = 1:act 'Нагнуться':dynamic $mitkagadsexStan2
        if hantsexa = 2:act 'Сесть свеху':dynamic $mitkagadsexCow2
    elseif horny_boyA < 100 and horny_boyB >= 100:
        act 'Стоять раком дальше':dynamic $mitkagadsexDogCum2_2
    elseif horny_boyA >= 100 and horny_boyB < 100:
        act 'Стоять раком дальше':dynamic $mitkagadsexDogCum2_1
    elseif horny_boyA >= 100 and horny_boyB >= 100:
        act 'Лечь на землю':dynamic $mitkagadsexHandsCum2
    end
}
$mitkagadsexDogCum2_1 = {
    *clr & cla
    minut += 5
    if temp = 1:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 2:$boy = 'Васян' & silavag = 0 & dick = 14
    if temp = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexDogCum2_1.jpg"></center>'
    'Понимая, что <<$boy>> скоро кончит, вы наращиваете темп, активнее действуя губами и языком...'
    gs 'zz_dynamic_sex', 'swallow'
    ''
    '<<$textsexhanter6>>'
    if temp = 1:$boy = 'Колямба' & silavag = 0 & dick = 15
    if temp = 2:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 3:$boy = 'Васян' & silavag = 0 & dick = 14
    ''
    hantsexa = rand(1,6)
    if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
    if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
    if hantsexa = 3:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
    if hantsexa = 4:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
    if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogVag1
    if hantsexa = 6:act 'Стать раком':dynamic $mitkagadsexDogAnal1
}
$mitkagadsexDogCum2_2 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    if temp = 1:$boy = 'Колямба' & silavag = 0 & dick = 15
    if temp = 2:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 3:$boy = 'Васян' & silavag = 0 & dick = 14
    gs'stat'
    if horny < 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexDogCum2_2.jpg"></center>'
    if horny >= 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexDogCum2_3.jpg"></center>'
    'Вы стоите раком, оттопырив попу, и чувствуете, что <<$boy>> начинает двигаться быстрее...'
    if horny >= 100:'<<$textsexhanter11>>' & orgasm += 1 & vaginalOrgasm += 1 & horny = 0 & manna += 15
    gs 'zz_dynamic_sex', 'sex_cum'
    ''
    '<<$textsexhanter6>>'
    if temp = 1:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 2:$boy = 'Васян' & silavag = 0 & dick = 14
    if temp = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
    ''
    hantsexa = rand(1,6)
    if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
    if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
    if hantsexa = 3:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
    if hantsexa = 4:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
    if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogVag1
    if hantsexa = 6:act 'Стать раком':dynamic $mitkagadsexDogAnal1
}
$mitkagadsexCow2 = {
    *clr & cla
    minut += 5
    if boyBsex = 0: boyBsex = 1 & sex += 1
    hantsexa = rand(1,2)
    if throat <= 25:horny_boyA += 5
    if throat > 25:horny_boyA += 10
    if vagina <= 25:horny_boyB += 20
    if vagina > 25:horny_boyB += 10
    pose = 2
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexCow2.jpg"></center>'
    'Один парень лежит на земле. Вы, пристраиваетесь к его члену, забравшись верхом на него. Второй парень в это время поднес член к вашим губам...'
    if temp = 1:
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'sex_start', 1
        gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    elseif temp = 2:
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'sex_start', 1
        gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    elseif temp = 3:
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'sex_start', 1
        gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    end
    ''
    '<<$textsexhanter7>>'
    if horny_boyA < 100 and horny_boyB < 100:
        if hantsexa = 1:act 'Нагнуться':dynamic $mitkagadsexStan2
        if hantsexa = 2:act 'Стать раком':dynamic $mitkagadsexDog2
    elseif horny_boyA < 100 and horny_boyB >= 100:
        act 'Скакать дальше':dynamic $mitkagadsexCowCum2_2
    elseif horny_boyA >= 100 and horny_boyB < 100:
        act 'Скакать дальше':dynamic $mitkagadsexCowCum2_1
    elseif horny_boyA >= 100 and horny_boyB >= 100:
        act 'Лечь на землю':dynamic $mitkagadsexHandsCum2
    end
}
$mitkagadsexCowCum2_1 = {
    *clr & cla
    minut += 5
    if temp = 1:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 2:$boy = 'Васян' & silavag = 0 & dick = 14
    if temp = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexCowCum2_1.jpg"></center>'
    'Понимая, что <<$boy>> скоро кончит, вы наращиваете темп, активнее действуя губами и языком...'
    gs 'zz_dynamic_sex', 'swallow'
    ''
    '<<$textsexhanter6>>'
    if temp = 1:$boy = 'Колямба' & silavag = 0 & dick = 15
    if temp = 2:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 3:$boy = 'Васян' & silavag = 0 & dick = 14
    ''
    hantsexa = rand(1,6)
    if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
    if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
    if hantsexa = 3:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
    if hantsexa = 4:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
    if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogVag1
    if hantsexa = 6:act 'Стать раком':dynamic $mitkagadsexDogAnal1
}
$mitkagadsexCowCum2_2 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    if temp = 1:$boy = 'Колямба' & silavag = 0 & dick = 15
    if temp = 2:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 3:$boy = 'Васян' & silavag = 0 & dick = 14
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexCowCum2_2.jpg"></center>'
    'Вы скачете на члене парня постепенно ускоряя темп, понимая что он скоро кончит...'
    if horny >= 100:'<<$textsexhanter11>>' & orgasm += 1 & vaginalOrgasm += 1 & horny = 0 & manna += 15
    gs 'zz_dynamic_sex', 'sex_cum'
    ''
    '<<$textsexhanter6>>'
    if temp = 1:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 2:$boy = 'Васян' & silavag = 0 & dick = 14
    if temp = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
    ''
    hantsexa = rand(1,6)
    if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
    if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
    if hantsexa = 3:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
    if hantsexa = 4:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
    if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogVag1
    if hantsexa = 6:act 'Стать раком':dynamic $mitkagadsexDogAnal1
}
$mitkagadsexStan2 = {
    *clr & cla
    minut += 5
    if boyBsex = 0: boyBsex = 1 & sex += 1
    hantsexa = rand(1,2)
    if throat <= 25:horny_boyA += 5
    if throat > 25:horny_boyA += 10
    if vagina <= 25:horny_boyB += 20
    if vagina > 25:horny_boyB += 10
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexStan2.jpg"></center>'
    'Вы стоите нагнувшись перед парнями. Один пристраивается сзади к вашей киске, второй поднес член к вашим губам...'
    if temp = 1:
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'sex_start', 1
        gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    elseif temp = 2:
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'sex_start', 1
        gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    elseif temp = 3:
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'sex_start', 1
        gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    end
    ''
    '<<$textsexhanter7>>'
    if horny_boyA < 100 and horny_boyB < 100:
        if hantsexa = 1:act 'Сесть свеху':dynamic $mitkagadsexCow2
        if hantsexa = 2:act 'Стать раком':dynamic $mitkagadsexDog2
    elseif horny_boyA < 100 and horny_boyB >= 100:
        act 'Стоять нагнувшись дальше':dynamic $mitkagadsexStanCum2_2
    elseif horny_boyA >= 100 and horny_boyB < 100:
        act 'Стоять нагнувшись дальше':dynamic $mitkagadsexStanCum2_1
    elseif horny_boyA >= 100 and horny_boyB >= 100:
        act 'Лечь на землю':dynamic $mitkagadsexHandsCum2
    end
}
$mitkagadsexStanCum2_1 = {
    *clr & cla
    minut += 5
    if temp = 1:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 2:$boy = 'Васян' & silavag = 0 & dick = 14
    if temp = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexStanCum2_1.jpg"></center>'
    'Понимая, что <<$boy>> скоро кончит, вы наращиваете темп, активнее действуя губами и языком...'
    gs 'zz_dynamic_sex', 'swallow'
    ''
    '<<$textsexhanter6>>'
    if temp = 1:$boy = 'Колямба' & silavag = 0 & dick = 15
    if temp = 2:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 3:$boy = 'Васян' & silavag = 0 & dick = 14
    ''
    hantsexa = rand(1,6)
    if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
    if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
    if hantsexa = 3:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
    if hantsexa = 4:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
    if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogVag1
    if hantsexa = 6:act 'Стать раком':dynamic $mitkagadsexDogAnal1
}
$mitkagadsexStanCum2_2 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    if temp = 1:$boy = 'Колямба' & silavag = 0 & dick = 15
    if temp = 2:$boy = 'Митька' & silavag = 0 & dick = 16
    if temp = 3:$boy = 'Васян' & silavag = 0 & dick = 14
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexStanCum2_2.jpg"></center>'
    'Вы стоите нагнувшись, оттопырив попу, и чувствуете, что <<$boy>> начинает двигаться быстрее...'
    if horny >= 100:'<<$textsexhanter11>>' & orgasm += 1 & vaginalOrgasm += 1 & horny = 0 & manna += 15
    gs 'zz_dynamic_sex', 'sex_cum'
    ''
    '<<$textsexhanter6>>'
    !if temp = 1:$boy = 'Митька' & silavag = 0 & dick = 16
    !if temp = 2:$boy = 'Васян' & silavag = 0 & dick = 14
    !if temp = 3:$boy = 'Колямба' & silavag = 0 & dick = 15
    ''
    hantsexa = rand(1,6)
    if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
    if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
    if hantsexa = 3:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
    if hantsexa = 4:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
    if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogVag1
    if hantsexa = 6:act 'Стать раком':dynamic $mitkagadsexDogAnal1
}
! Один парень vs ГГ
$mitkagadsexOral1 = {
    *clr & cla
    minut += 5
    horny += 5
    hantsexa = rand(1,6)
    lubonus += 1
    if throat <= 15:horny_boyA += 5
    if throat > 15:horny_boyA += 10
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexOral1.'+rand(1,2)+'.jpg"></center>'
    'Вы стоите на коленях перед парнем. <<$boy>> достав свой <<dick>> сантиметровый член, подносит его к вашим губам...'
    gs 'zz_dynamic_sex', 'bj'
    if klismaday ! day and dirty_dickA > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
        if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
        if hantsexa = 4:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
        if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogVag1
        if hantsexa = 6:act 'Стать раком':dynamic $mitkagadsexDogAnal1
    else
        act 'Сосать дальше':dynamic $mitkagadsexOralCum1
    end
}
$mitkagadsexOralCum1 = {
    *clr & cla
    minut += 5
    protect = 0
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexOralCuml1.jpg"></center>'
    'Понимая, что <<$boy>> скоро кончит, вы наращиваете темп...'
    if klismaday ! day and dirty_dickA > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
    gs 'zz_dynamic_sex', 'swallow'
    ''
    '<<$textsexhanter3>>'
    act 'Далее':gt $loc, $metka
}
$mitkagadsexSideVag1 = {
    *clr & cla
    minut += 5
    if boyAsex = 0: boyAsex = 1 & sex += 1
    hantsexa = rand(1,5)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    gs'stat'
    if horny < 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexSideVag1.1.jpg"></center>'
    if horny >= 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexSideVag1.2.jpg"></center>'
    'Вы лежите на боку, <<$boy>> пристраивается к вашей киске...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
        if hantsexa = 2:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
        if hantsexa = 3:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
        if hantsexa = 4:act 'Стать раком':dynamic $mitkagadsexDogVag1
        if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogAnal1
    else
        act 'Лежать на боку дальше':dynamic $mitkagadsexSideVagCum1
    end
}
$mitkagadsexSideVagCum1 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexSideVagCum1.jpg"></center>'
    'Вы лежите на боку, чувствуя, что <<$boy>> постепенно начинает двигаться быстрее...'
    if horny >= 100:'<<$textsexhanter11>>' & orgasm += 1 & vaginalOrgasm += 1 & horny = 0 & manna += 15
    gs 'zz_dynamic_sex', 'sex_cum'
    ''
    '<<$textsexhanter3>>'
    act 'Далее':gt $loc, $metka
}
$mitkagadsexMisVag1 = {
    *clr & cla
    minut += 5
    if boyAsex = 0: boyAsex = 1 & sex += 1
    hantsexa = rand(1,5)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    pose = 0
    gs'stat'
    if horny < 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexMisVag1.1.jpg"></center>'
    if horny >= 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexMisVag1.2.jpg"></center>'
    'Вы лежите на спине, <<$boy>> рядом, на боку, пристраивается к вашей киске...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
        if hantsexa = 2:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
        if hantsexa = 3:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
        if hantsexa = 4:act 'Стать раком':dynamic $mitkagadsexDogVag1
        if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogAnal1
    else
        act 'Лежать на земле':dynamic $mitkagadsexHandsCum1
    end
}
$mitkagadsexDogVag1 = {
    *clr & cla
    minut += 5
    if boyAsex = 0: boyAsex = 1 & sex += 1
    hantsexa = rand(1,5)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexDogVag1.jpg"></center>'
    'Вы стоите раком, <<$boy>> сзади пристраивается к вашей киске...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
        if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
        if hantsexa = 4:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
        if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogAnal1
    else
        act 'Сосать':dynamic $mitkagadsexOral1
    end
}
$mitkagadsexCowVag1 = {
    *clr & cla
    minut += 5
    if boyAsex = 0: boyAsex = 1 & sex += 1
    hantsexa = rand(1,5)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    pose = 2
    gs'stat'
    if horny < 60:
        '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexCowVag1.'+rand(1,2)+'.jpg"></center>'
    else
        '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexCowVag1.'+rand(3,4)+'.jpg"></center>'
    end
    '<<$boy>> лежит на земле, а вы пристраиваетесь к его члену, забравшись верхом на парня...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
        if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
        if hantsexa = 3:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
        if hantsexa = 4:act 'Стать раком':dynamic $mitkagadsexDogVag1
        if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogAnal1
    else
        act 'Скакать дальше':dynamic $mitkagadsexCowVagCum1
    end
}
$mitkagadsexCowVagCum1 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    pose = 0
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexCowVagCum1.jpg"></center>'
    'Вы скачете на члене парня постепенно ускоряя темп, понимая что он скоро кончит...'
    if horny >= 100:'<<$textsexhanter11>>' & orgasm += 1 & vaginalOrgasm += 1 & horny = 0 & manna += 15
    gs 'zz_dynamic_sex', 'sex_cum'
    ''
    '<<$textsexhanter3>>'
    act 'Далее':gt $loc, $metka
}
$mitkagadsexDogAnal1 = {
    *clr & cla
    minut += 5
    if boyAsexa = 0: boyAsexa = 1 & anal += 1
    hantsexa = rand(1,5)
    if anus <= 25:horny_boyA += 30
    if anus > 25:horny_boyA += 20
    dirty_dickA += 1
    gs'stat'
    if horny < 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexDogAnal1.'+rand(1,2)+'.jpg"></center>'
    if horny >= 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexDogAnal1.'+rand(3,4)+'.jpg"></center>'
    'Вы стоите раком, <<$boy>> сзади пристраивается к вашей попе...'
    gs 'zz_dynamic_sex', 'anal_start', 'dick'
    gs 'zz_dynamic_sex', 'anal', 'dick', 1
    ''
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
        if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
        if hantsexa = 4:act 'Сесть свеху':dynamic $mitkagadsexCowAnal1
        if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogVag1
    else
        act 'Стоять раком дальше':dynamic $mitkagadsexDogAnalCum1
    end
}
$mitkagadsexDogAnalCum1 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    pose = 1
    gs 'zz_funcs', 'cum', 'anus'
    protect = 0
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexDogAnalCum1.jpg"></center>'
    'Вы стоите раком, оттопырив попу, и чувствуете, что <<$boy>> начинает двигаться быстрее...'
    if horny >= 100:'<<$textsexhanter12>>' & analorgasm += 1 & horny = 0 & orgasm += 1 & manna += 15
    'Через некоторое время <<$boy>> застонал и вы почувствовали как вашу попу наполняет тепло.'
    ''
    '<<$textsexhanter3>>'
    act 'Далее':gt $loc, $metka
}
$mitkagadsexCowAnal1 = {
    *clr & cla
    minut += 5
    if boyAsexa = 0: boyAsexa = 1 & anal += 1
    hantsexa = rand(1,5)
    if anus <= 25:horny_boyA += 30
    if anus > 25:horny_boyA += 20
    dirty_dickA += 1
    gs'stat'
    if horny < 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexCowAnal1.'+rand(1,2)+'.jpg"></center>'
    if horny >= 60:'<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexCowAnal1.'+rand(3,4)+'.jpg"></center>'
    '<<$boy>> лежит на земле, а вы пристраиваетесь к его члену, забравшись верхом на парня...'
    gs 'zz_dynamic_sex', 'anal_start', 'dick'
    gs 'zz_dynamic_sex', 'anal', 'dick', 1
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkagadsexSideVag1
        if hantsexa = 2:act 'Лечь на спину':dynamic $mitkagadsexMisVag1
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkagadsexCowVag1
        if hantsexa = 4:act 'Стать раком':dynamic $mitkagadsexDogVag1
        if hantsexa = 5:act 'Стать раком':dynamic $mitkagadsexDogAnal1
    else
        act 'Лечь на землю':dynamic $mitkagadsexHandsCum1
    end
}
$mitkagadsexHandsCum1 = {
    *clr & cla
    minut += 5
    protect = 0
    gs 'zz_funcs', 'cum', 'belly'
    hj += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkagadsexHandsCum1.'+rand(1,2)+'.jpg"></center>'
    'Вы лежите на земле. <<$boy>>, чувствуя приближающийся оргазм, вложив вам в ладошку свой член, и сказал дрочить. Вы принялись за работу и вскоре были вознаграждены за свое усердие, он застонал и вы почувствовали горячие капли спермы на вашем теле.'
    '<<$textsexhanter3>>'
    act 'Далее':gt $loc, $metka
}
! Один парень vs ГГ и Мира
$mitkaforestsexOral1_1 = {
    *clr & cla
    minut += 5
    horny += 5
    hantsexa = rand(1,7)
    if throat <= 15:horny_boyA += 5
    if throat > 15:horny_boyA += 10
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexOral1_1.jpg"></center>'
    'Вы c Мирой стоите на коленях перед парнем. <<$boy>> достав свой <<dick>> сантиметровый член, подносит его к вашим губам...'
    gs 'zz_dynamic_sex', 'bj'
    'Мира стоит рядом с вами, не вмешиваясь в процесс.'
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide1_1
        if hantsexa = 2:act 'Смотреть':dynamic $mitkaforestsexSide1_2
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow1_1
        if hantsexa = 4:act 'Смотреть':dynamic $mitkaforestsexCow1_2
        if hantsexa = 5:act 'Стать раком':dynamic $mitkaforestsexDog1_1
        if hantsexa = 6:act 'Смотреть':dynamic $mitkaforestsexDog1_2
        if hantsexa = 7:act 'Стать раком':dynamic $mitkaforestsexDog1_3
    else
        act 'Сосать дальше':dynamic $mitkaforestsexOralCum1_1
    end
}
$mitkaforestsexOral1_2 = {
    *clr & cla
    minut += 5
    horny += 5
    hantsexa = rand(1,7)
    if throat <= 15:horny_boyA += 5
    if throat > 15:horny_boyA += 10
    if mirasextimes < 50:horny_boyA += 5
    if mirasextimes >= 50:horny_boyA += 10
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexOral1_2.'+rand(1,2)+'.jpg"></center>'
    'Вы С Мирой стоите на коленях перед парнем. <<$boy>> достав свой <<dick>> сантиметровый член, подносит его к вашим губам...'
    gs 'zz_dynamic_sex', 'bj'
    'Мира опустившись ниже ласкает своим язычком яйца парня, доставляя ему дополнительное удовольствие.'
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide1_1
        if hantsexa = 2:act 'Смотреть':dynamic $mitkaforestsexSide1_2
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow1_1
        if hantsexa = 4:act 'Смотреть':dynamic $mitkaforestsexCow1_2
        if hantsexa = 5:act 'Стать раком':dynamic $mitkaforestsexDog1_1
        if hantsexa = 6:act 'Смотреть':dynamic $mitkaforestsexDog1_2
        if hantsexa = 7:act 'Стать раком':dynamic $mitkaforestsexDog1_3
    else
        act 'Сосать дальше':dynamic $mitkaforestsexOralCum1_1
    end
}
$mitkaforestsexOral1_3 = {
    *clr & cla
    minut += 5
    horny += 5
    hantsexa = rand(1,7)
    if throat <= 15:horny_boyA += 5
    if throat > 15:horny_boyA += 10
    if mirasextimes < 50:horny_boyA += 5
    if mirasextimes >= 50:horny_boyA += 10
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexOral1_3.'+rand(1,2)+'.jpg"></center>'
    'Вы c Мирой стоите на коленях перед парнем. <<$boy>> достав свой <<dick>> сантиметровый член, подносит его к вашим губам...'
    gs 'zz_dynamic_sex', 'bj'
    'Вы с Мирославой усердно сосете и лижете член парня, ваши губы и языки иногда соприкасаются, сливаясь в таком своеобразном поцелуе.'
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide1_1
        if hantsexa = 2:act 'Смотреть':dynamic $mitkaforestsexSide1_2
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow1_1
        if hantsexa = 4:act 'Смотреть':dynamic $mitkaforestsexCow1_2
        if hantsexa = 5:act 'Стать раком':dynamic $mitkaforestsexDog1_1
        if hantsexa = 6:act 'Смотреть':dynamic $mitkaforestsexDog1_2
        if hantsexa = 7:act 'Стать раком':dynamic $mitkaforestsexDog1_3
    else
        act 'Сосать дальше':dynamic $mitkaforestsexOralCum1_1
    end
}
$mitkaforestsexOralCum1_1 = {
    *clr & cla
    minut += 5
    protect = 0
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexOralCuml1_1.jpg"></center>'
    'Понимая, что <<$boy>> скоро кончит, вы наращиваете темп. Мира стоит рядом с вами, не вмешиваясь в процесс.'
    gs 'zz_dynamic_sex', 'bj'
    gs 'zz_dynamic_sex', 'swallow'
    ''
    '<<$textsexhanter10>>'
    act 'Далее':gt $loc, $metka
}
$mitkaforestsexSide1_1 = {
    *clr & cla
    minut += 5
    hantsexa = rand(1,6)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    if boyAsex = 0: boyAsex = 1 & sex += 1
    pose = 0
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexSide1_1.jpg"></center>'
    'Вы лежите на боку, <<$boy>> пристраивается к вашей киске...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    'Мирослава лежит рядом с вами и наблюдает, как <<dick>> сантиметровый поршень долбит в вашу <<$vaginatipe2>> вагину.'
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Смотреть':dynamic $mitkaforestsexSide1_2
        if hantsexa = 2:act 'Сесть сверху':dynamic $mitkaforestsexCow1_1
        if hantsexa = 3:act 'Смотреть':dynamic $mitkaforestsexCow1_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexDog1_1
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexDog1_2
        if hantsexa = 6:act 'Стать раком':dynamic $mitkaforestsexDog1_3
    else
        act 'Лежать на боку дальше':dynamic $mitkaforestsexSideCum1_1
    end
}
$mitkaforestsexSideCum1_1 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexSideCum1_1.jpg"></center>'
    'Вы лежите на боку, немного изменив позу, <<$boy>> постепенно начинает двигаться быстрее...'
    if horny >= 100:'<<$textsexhanter11>>' & orgasm += 1 & vaginalOrgasm += 1 & horny = 0 & manna += 15
    gs 'zz_dynamic_sex', 'sex_cum'
    ''
    '<<$textsexhanter10>>'
    act 'Далее':gt $loc, $metka
}
$mitkaforestsexSide1_2 = {
    *clr & cla
    minut += 5
    horny += 5
    if mirasextimes < 50:horny_boyA += 20
    if mirasextimes >= 50:horny_boyA += 10
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexSide1_2.jpg"></center>'
    if mirasextimes < 50:'Вы лежите рядом с Мирославой и смотрите как <<$boy>> своим <<dick>> сантиметровым членом таранит её разработанную киску.'
    if mirasextimes >= 50:'Вы лежите рядом с Мирославой и смотрите как <<$boy>> своим <<dick>> сантиметровым членом таранит её раздолбаную вагину.'
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        hantsexa = rand(1,6)
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide1_1
        if hantsexa = 2:act 'Сесть сверху':dynamic $mitkaforestsexCow1_1
        if hantsexa = 3:act 'Смотреть':dynamic $mitkaforestsexCow1_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexDog1_1
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexDog1_2
        if hantsexa = 6:act 'Стать раком':dynamic $mitkaforestsexDog1_3
    else
        hantsexa = rand(1,3)
        if hantsexa = 1:act 'Сосать':dynamic $mitkaforestsexOral1_1
        if hantsexa = 2:act 'Сосать':dynamic $mitkaforestsexOral1_2
        if hantsexa = 3:act 'Сосать':dynamic $mitkaforestsexOral1_3
    end
}
$mitkaforestsexCow1_1 = {
    *clr & cla
    minut += 5
    hantsexa = rand(1,6)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    if boyAsex = 0: boyAsex = 1 & sex += 1
    pose = 2
    gs'stat'
    if miralesb = 0:
        '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCow1_1.jpg"></center>'
    else
        '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexСowKiss1_2.jpg"></center>'
        horny += 5
    end
    '<<$boy>> лежит на земле, а вы пристраиваетесь к его члену, забравшись верхом на парня...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    if miralesb = 0:'Мирослава лежит рядом с вами и наблюдает, как вы скачете на члене парня.'
    if miralesb > 2:'Пока вы скачете на парне, Мирослава, приблизив свое лицо, целует ваши губы, чувствуя как ваше тело содрогается от ритмичных ударов члена.'
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide1_1
        if hantsexa = 2:act 'Смотреть':dynamic $mitkaforestsexSide1_2
        if hantsexa = 3:act 'Смотреть':dynamic $mitkaforestsexCow1_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexDog1_1
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexDog1_2
        if hantsexa = 6:act 'Стать раком':dynamic $mitkaforestsexDog1_3
    else
        act 'Скакать дальше':dynamic $mitkaforestsexCowCum1_1
    end
}
$mitkaforestsexCowCum1_1 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCowCum1_1.jpg"></center>'
    'Вы скачете на члене парня постепенно ускоряя темп, понимая что он скоро кончит...'
    if horny >= 100:'<<$textsexhanter11>>' & orgasm += 1 & vaginalOrgasm += 1 & horny = 0 & manna += 15
    gs 'zz_dynamic_sex', 'sex_cum'
    ''
    '<<$textsexhanter10>>'
    act 'Далее':gt $loc, $metka
}
$mitkaforestsexCow1_2 = {
    *clr & cla
    minut += 5
    horny += 10
    hantsexa = rand(1,6)
    if mirasextimes < 50:horny_boyA += 20
    if mirasextimes >= 50:horny_boyA += 10
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexСow1_2.'+rand(1,2)+'.jpg"></center>'
    if mirasextimes < 50:'Вы сидите у изголовья парня и смотрите как как Мира скачет на его члене. Одновременно с этим <<$boy>>, просунув руку между ваших ног, теребит пальцами вашу киску, постепенно возбуждая вас.'
    if mirasextimes >= 50:'Вы сидите у изголовья парня и смотрите как Мира насаживается своей раздолбаной вагиной на <<dick>> сантиметровый член парня. Одновременно с этим <<$boy>>, просунув руку между ваших ног, теребит пальцами вашу киску, постепенно возбуждая вас.'
    if miralesb > 0:'Вы можете нагнуться и поцеловать <a href="exec:dynamic $mitkaforestCowKiss1_1">Миру</a>.'
    if horny >= 100:'<<$textsexhanter11>>' & orgasm += 1 & vaginalOrgasm += 1 & horny = 0 & manna += 15
    'Вы можете вынуть из Миры член парня и <a href="exec:dynamic $mitkaforestsexCowOral1_1">пососать</a>.'
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide1_1
        if hantsexa = 2:act 'Смотреть':dynamic $mitkaforestsexSide1_2
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow1_1
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexDog1_1
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexDog1_2
        if hantsexa = 6:act 'Стать раком':dynamic $mitkaforestsexDog1_3
    else
        act 'Смотреть дальше':dynamic $mitkaforestsexCowCum1_2
    end
}
$mitkaforestCowKiss1_1 = {
    *clr & cla
    minut += 5
    horny += 5
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexСowKiss1_1.jpg"></center>'
    'Наблюдая как Мира скачет на члене парня, вам вдруг захотелось поцеловать её. Вы приблизили губы к её губам и слились в страстном поцелуе, ощущая ритмичные толчки её тела.'
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide1_1
        if hantsexa = 2:act 'Смотреть':dynamic $mitkaforestsexSide1_2
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow1_1
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexDog1_1
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexDog1_2
        if hantsexa = 6:act 'Стать раком':dynamic $mitkaforestsexDog1_3
    else
        act 'Смотреть дальше':dynamic $mitkaforestsexCowCum1_2
    end
}
$mitkaforestsexCowCum1_2 = {
    *clr & cla
    minut += 1
    horny += 5
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCowCum1_2.jpg"></center>'
    'Мира скачет на члене парня постепенно ускоряя темп. Внезапно <<$boy>> застонал и вы поняли, что он кончил в Мирославу.'
    ''
    '<<$textsexhanter10>>'
    act 'Далее':gt $loc, $metka
}
$mitkaforestsexCowOral1_1 = {
    *clr & cla
    minut += 5
    horny += 5
    if throat <= 15:horny_boyA += 5
    if throat > 15:horny_boyA += 10
    gs'stat'
    if horny_boyA < 100:'<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexСowOral1_1.jpg"></center>'
    if horny_boyA >= 100:'<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexСowOralCuml1_1.jpg"></center>'
    'Вынув член из вагину Миры вы поднесли его к своим губам...'
    gs 'zz_dynamic_sex', 'bj'
    if horny_boyA >= 100:
        gs 'zz_dynamic_sex', 'swallow'
    end
    ''
    if horny_boyA < 100:'<<$textsexhanter4>>'
    if horny_boyA >= 100:'<<$textsexhanter10>>'
    ''
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide1_1
        if hantsexa = 2:act 'Смотреть':dynamic $mitkaforestsexSide1_2
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow1_1
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexDog1_1
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexDog1_2
        if hantsexa = 6:act 'Стать раком':dynamic $mitkaforestsexDog1_3
    else
        act 'Далее':gt $loc, $metka
    end
}
$mitkaforestsexDog1_1 = {
    *clr & cla
    minut += 5
    hantsexa = rand(1,6)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    if boyAsex = 0: boyAsex = 1 & sex += 1
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDog1_1.'+rand(1,2)+'.jpg"></center>'
    'Вы стоите раком, <<$boy>> сзади пристраивается к вашей киске...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    'Мирослава сидит на коленках рядом с вами и наблюдает, как <<dick>> сантиметровый поршень долбит в вашу <<$vaginatipe2>> вагину.'
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide1_1
        if hantsexa = 2:act 'Смотреть':dynamic $mitkaforestsexSide1_2
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow1_1
        if hantsexa = 4:act 'Смотреть':dynamic $mitkaforestsexCow1_2
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexDog1_2
        if hantsexa = 6:act 'Стать раком':dynamic $mitkaforestsexDog1_3
    else
        act 'Стоять раком дальше':dynamic $mitkaforestsexDogCum1_1
    end
}
$mitkaforestsexDogCum1_1 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDogCum1_1.jpg"></center>'
    'Вы стоите раком, оттопырив попу, и чувствуете, что <<$boy>> начинает двигаться быстрее...'
    if horny >= 100:'<<$textsexhanter11>>' & orgasm += 1 & vaginalOrgasm += 1 & horny = 0 & manna += 15
    gs 'zz_dynamic_sex', 'sex_cum'
    ''
    '<<$textsexhanter10>>'
    act 'Далее':gt $loc, $metka
}
$mitkaforestsexDog1_2 = {
    *clr & cla
    minut += 5
    horny += 5
    hantsexa = rand(1,6)
    if mirasextimes < 50:horny_boyA += 20
    if mirasextimes >= 50:horny_boyA += 10
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDog1_2.'+rand(1,2)+'.jpg"></center>'
    if mirasextimes < 50:'Вы стоите на раком рядом с Мирославой и смотрите как <<$boy>> своим <<dick>> сантиметровым членом таранит её разработанную киску.'
    if mirasextimes >= 50:'Вы стоите на раком рядом с Мирославой и смотрите как <<$boy>> своим <<dick>> сантиметровым членом таранит её раздолбаную вагину.'
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide1_1
        if hantsexa = 2:act 'Смотреть':dynamic $mitkaforestsexSide1_2
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow1_1
        if hantsexa = 4:act 'Смотреть':dynamic $mitkaforestsexCow1_2
        if hantsexa = 5:act 'Стать раком':dynamic $mitkaforestsexDog1_1
        if hantsexa = 6:act 'Стать раком':dynamic $mitkaforestsexDog1_3
    else
        act 'Смотреть дальше':dynamic $mitkaforestsexDogCum1_2
    end
}
$mitkaforestsexDogCum1_2 = {
    *clr & cla
    minut += 1
    horny += 5
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDogCum1_2.jpg"></center>'
    'Вы видите, что <<$boy>>, находясь в Мире, постепенно ускоряет темп. Внезапно <<$boy>> застонал и вы поняли, что он кончил в неё.'
    ''
    '<<$textsexhanter10>>'
    act 'Далее':gt $loc, $metka
}
$mitkaforestsexDog1_3 = {
    *clr & cla
    minut += 5
    hantsexa = rand(1,6)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    if boyAsex = 0: boyAsex = 1 & sex += 1
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDog1_3.'+rand(1,2)+'.jpg"></center>'
    '<<$boy>> поставил вас раком, а Миру взгромоздил сверху, на вашу спину, сделав из вас своеобразный бутерброд. Оглядев эту конструкцию он начал пристраиватся к вашей киске...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    'Через некоторое время достав из вас свой член, он вснул его в Мирославу, и вы почувствовали, как задрожало её тело под его ритмичными ударами, заодно раскачивая и вас в такт.'
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide1_1
        if hantsexa = 2:act 'Смотреть':dynamic $mitkaforestsexSide1_2
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow1_1
        if hantsexa = 4:act 'Смотреть':dynamic $mitkaforestsexCow1_2
        if hantsexa = 5:act 'Стать раком':dynamic $mitkaforestsexDog1_1
        if hantsexa = 6:act 'Смотреть':dynamic $mitkaforestsexDog1_2
    else
        act 'Стать раком':dynamic $mitkaforestsexDogCum1_3
    end
}
$mitkaforestsexDogCum1_3 = {
    *clr & cla
    minut += 5
    pose = 1
    gs 'zz_funcs', 'cum', 'ass'
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDogCum1_3.'+rand(1,2)+'.jpg"></center>'
    'Чувствуя приближающийся оргазм <<$boy>> поставил вас раком, рядом друг с другом и начал надрачивать свой член. Вскоре он застонал и вы почувствовали горячие капли спермы на вашей попе.'
    '<<$textsexhanter10>>'
    act 'Далее':gt $loc, $metka
}
! Два парня vs ГГ и Мира
$mitkaforestsexOral2_1 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    hantsexa = rand(1,3)
    if throat <= 15:horny_boyA += 5
    if throat > 15:horny_boyA += 10
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexOral2_1.'+rand(1,2)+'.jpg"></center>'
    'Вы стоите на коленях перед парнем. <<$boy>> достав свой <<dick>> сантиметровый член, подносит его к вашим губам...'
    gs 'zz_dynamic_sex', 'bj'
    !'<<$textsexhanter8>>'
    ''
    'Недалеко от вас стоит на корточках <a href="exec:dynamic $mitkaforestsexOral_mira2_1">Мира</a>.'
    if mirasextimes < 50:horny_boyB += 5
    if mirasextimes >= 50:horny_boyB += 10
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexCow2_1
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexDog2_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexDog2_2
    else
        act 'Сосать дальше':dynamic $mitkaforestsexOralCum2_1
    end
}
$mitkaforestsexDog2_1 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    if mirasextimes < 50:horny_boyB += 5
    if mirasextimes >= 50:horny_boyB += 10
    if boyAsex = 0: boyAsex = 1 & sex += 1
    pose = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDog2_1.'+rand(1,2)+'.jpg"></center>'
    'Вы стоите раком перед парнем, он пристраивается к вам сзади...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    'Недалеко от вас стоит раком Мира, слегка постанывая и раскачиваясь в такт толчков второго парня.'
    if horny_boyB >= 100:'Неожиданно парень хватает её за волосы и поставив перед собой на колени, начинает дрочить перед лицом.'
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100 and horny_boyB < 100:
        hantsexa = rand(1,2)
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide2_1
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexDog2_2
    elseif horny_boyA < 100 and horny_boyB >= 100:
        hantsexa = rand(1,3)
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide2_2
        if hantsexa = 2:act 'Лечь на бок':dynamic $mitkaforestsexSide2_3
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow2_1
    else
        act 'Стоять на колени':dynamic $mitkaforestsexOralCum2_1
    end
}
$mitkaforestsexDog2_2 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    if mirasextimes < 50:horny_boyB += 20
    if mirasextimes >= 50:horny_boyB += 10
    pose = 1
    if boyAsex = 0: boyAsex = 1 & sex += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDog2_2.'+rand(1,2)+'.jpg"></center>'
    'Вы стоите раком перед парнем, он пристраивается к вам сзади...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    'Недалеко от вас скачет верхом на втором парне Мира.'
    if horny_boyB >= 100:'Неожиданно парень грубо спихивает её с себя и поставив перед собой на колени, начинает дрочить перед лицом.'
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100 and horny_boyB < 100:
        hantsexa = rand(1,2)
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexCow2_1
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexDog2_1
    elseif horny_boyA < 100 and horny_boyB >= 100:
        hantsexa = rand(1,3)
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide2_2
        if hantsexa = 2:act 'Лечь на бок':dynamic $mitkaforestsexSide2_3
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow2_1
    else
        act 'Стоять на колени':dynamic $mitkaforestsexOralCum2_1
    end
}
$mitkaforestsexSide2_1 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    if mirasextimes < 50:horny_boyB += 20
    if mirasextimes >= 50:horny_boyB += 10
    pose = 1
    if boyAsex = 0: boyAsex = 1 & sex += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexSide2_1.'+rand(1,2)+'.jpg"></center>'
    'Вы лежите на боку, <<$boy>> пристраивается к вашей киске...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    'Прямо перед вами Мира с энтузиазмом отсасывает второму парню.'
    if horny_boyB >= 100:'Неожиданно парень высовывает член из её рта и начинает дрочить перед лицом.'
    ''
    '<<$textsexhanter4>>'
    if horny_boyA < 100 and horny_boyB < 100:
        hantsexa = rand(1,2)
        if hantsexa = 1:act 'Стать раком':dynamic $mitkaforestsexDog2_1
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexDog2_2
    elseif horny_boyA < 100 and horny_boyB >= 100:
        !boyB_cum = 1
        hantsexa = rand(1,3)
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide2_2
        if hantsexa = 2:act 'Лечь на бок':dynamic $mitkaforestsexSide2_3
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow2_1
    else
        act 'Стоять на колени':dynamic $mitkaforestsexOralCum2_1
    end
}
$mitkaforestsexOralCum2_1 = {
    *clr & cla
    minut += 5
    gs 'zz_funcs', 'cum', 'face'
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexOralCum2_1.jpg"></center>'
    'Вы стоите на коленях перед парнем, его член перед вашим лицом...'
    gs 'zz_dynamic_sex', 'bj'
    !'<<$textsexhanter8>>'
    gs 'zz_dynamic_sex', 'swallow'
    '<<$textsexhanter3>>'
    ''
    if horny_boyB < 100 and boyB_cum = 0:
        temp = rand(1,2)
        if temp = 1:'Недалеко от вас постанывает <a href="exec:dynamic $mitkaforestsexDog_mira2_1">Мира</a>.'
        if temp = 2:'Недалеко от вас постанывает <a href="exec:dynamic $mitkaforestsexCow_mira2_1">Мира</a>.'
    elseif horny_boyB >= 100 and boyB_cum = 0:
        'Недалеко от вас стоит на коленях с открытым ртом <a href="exec:dynamic $mitkaforestsexOralCum_mira2_1">Мира</a>.'
    else
        'Растрепаная Мира сидит на земле недалеко от вас и приводит себя в порядок, изредка кидая взгляды в вашу сторону.'
    end
    protect = 0
    ''
    if boyB_cum = 0:
        act 'Далее':dynamic $mitkaforestsexRelax2
    else
        act 'Далее':boyB_cum = 0 & gt $loc, $metka
    end
}
$mitkaforestsexRelax2 = {
    *clr & cla
    minut += 5
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexRelax2.jpg"></center>'
    'Ничем не занятые вы стоите в сторонке и приводите себя в порядок, изредка поглядывая на постанывающую Мирославу.'
    if horny_boyB < 100:
        temp = rand(1,2)
        if temp = 1:act 'Смотреть':dynamic $mitkaforestsexDog_mira2_1
        if temp = 2:act 'Смотреть':dynamic $mitkaforestsexCow_mira2_1
    else
        act 'Смотреть':dynamic $mitkaforestsexOralCum_mira2_1
    end
}
$mitkaforestsexSide2_2 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    temp = rand(1,3)
    hantsexa = rand(1,5)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    pose = 0
    if boyAsex = 0: boyAsex = 1 & sex += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexSide2_2.'+rand(1,2)+'.jpg"></center>'
    'Вы лежите на боку, <<$boy>> пристраивается к вашей киске...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    if horny_boyA < 100 and boyB_cum = 0:'Недалеко от вас стоит на коленях с открытым ртом <a href="exec:dynamic $mitkaforestsexOralCum_mira2_1">Мира</a>.'
    if horny_boyA >= 100 and boyB_cum = 0:'Недалеко от вас второй парень кончает, стоящей на коленях перед ним Мире, прямо в широко открытый рот.'
    if boyB_cum = 1:'Растрепаная Мира сидит на земле недалеко от вас и приводит себя в порядок, изредка кидая взгляды в вашу сторону.'
    ''
    '<<$textsexhanter4>>'
    boyB_cum = 1
    if horny_boyA < 100:
        hantsexa = rand(1,2)
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide2_3
        if hantsexa = 2:act 'Сесть сверху':dynamic $mitkaforestsexCow2_1
    else
        act 'Стать на колени':dynamic $mitkaforestsexOralCum2_1
    end
}
$mitkaforestsexSide2_3 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    temp = rand(1,3)
    hantsexa = rand(1,5)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    pose = 1
    if boyAsex = 0: boyAsex = 1 & sex += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexSide2_3.'+rand(1,2)+'.jpg"></center>'
    'Вы лежите на боку, <<$boy>> пристраивается к вашей киске...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    if horny_boyA < 100 and boyB_cum = 0:'Недалеко от вас стоит на коленях с открытым ртом <a href="exec:dynamic $mitkaforestsexOralCum_mira2_1">Мира</a>.'
    if horny_boyA >= 100 and boyB_cum = 0:'Недалеко от вас второй парень кончает, стоящей на коленях перед ним Мире, прямо в широко открытый рот.'
    if boyB_cum = 1:'Растрепаная Мира сидит на земле недалеко от вас и приводит себя в порядок, изредка кидая взгляды в вашу сторону.'
    ''
    '<<$textsexhanter4>>'
    boyB_cum = 1
    if horny_boyA < 100:
        hantsexa = rand(1,2)
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide2_2
        if hantsexa = 2:act 'Сесть сверху':dynamic $mitkaforestsexCow2_1
    else
        act 'Стать на колени':dynamic $mitkaforestsexOralCum2_1
    end
}
$mitkaforestsexCow2_1 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    temp = rand(1,3)
    hantsexa = rand(1,5)
    if vagina <= 25:horny_boyA += 20
    if vagina > 25:horny_boyA += 10
    pose = 2
    if boyAsex = 0: boyAsex = 1 & sex += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCow2_1.'+rand(1,2)+'.jpg"></center>'
    '<<$boy>> ложится на землю, вы, перекинув ногу через его тело, пристраиваетесь сверху...'
    gs 'zz_dynamic_sex', 'sex_start', 1
    gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    ''
    if horny_boyA < 100 and boyB_cum = 0:'Недалеко от вас стоит на коленях с открытым ртом <a href="exec:dynamic $mitkaforestsexOralCum_mira2_1">Мира</a>.'
    if horny_boyA >= 100 and boyB_cum = 0:'Недалеко от вас второй парень кончает, стоящей на коленях перед ним Мире, прямо в широко открытый рот.'
    if boyB_cum = 1:'Растрепаная Мира сидит на земле недалеко от вас и приводит себя в порядок, изредка кидая взгляды в вашу сторону.'
    ''
    '<<$textsexhanter4>>'
    boyB_cum = 1
    if horny_boyA < 100:
        hantsexa = rand(1,2)
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide2_2
        if hantsexa = 2:act 'Лечь на бок':dynamic $mitkaforestsexSide2_3
    else
        act 'Стать на колени':dynamic $mitkaforestsexOralCum2_1
    end
}
$mitkaforestsexOral_mira2_1 = {
    *clr & cla
    minut += 1
    horny += 5
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexOral_mira2_1.'+rand(1,2)+'.jpg"></center>'
    'Скосив взгляд в сторону, вы видите Мирославу, усердно отсасывающую второму парню.'
    '<<$textsexhanter4>>'
    if horny_boyA < 100:
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexCow2_1
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexDog2_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexDog2_2
    else
        act 'Сосать дальше':dynamic $mitkaforestsexOralCum2_1
    end
}
$mitkaforestsexOralCum_mira2_1 = {
    *clr & cla
    minut += 1
    horny += 5
    boyB_cum = 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexOralCum_mira2_1.jpg"></center>'
    'Посмотрев в сторону Миры, вы видите парня кончающего в её открытый рот, пока она стоит на коленях перед ним.'
    if horny_boyA < 100:
        '<<$textsexhanter4>>'
        hantsexa = rand(1,3)
        if hantsexa = 1:act 'Лечь на бок':dynamic $mitkaforestsexSide2_2
        if hantsexa = 2:act 'Лечь на бок':dynamic $mitkaforestsexSide2_3
        if hantsexa = 3:act 'Сесть сверху':dynamic $mitkaforestsexCow2_1
    else
        act 'Далее':gt $loc, $metka
    end
}
$mitkaforestsexDog_mira2_1 = {
    *clr & cla
    minut += 1
    horny += 5
    if mirasextimes < 50:horny_boyB += 20
    if mirasextimes >= 50:horny_boyB += 10
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCow_mira2_1.'+rand(1,2)+'.jpg"></center>'
    'Мира, постанывая, бойко скачет на члене второго парня.'
    if horny_boyB >= 100:'Неожиданно парень хватает Миру за волосы и поставив перед собой на колени, начинает дрочить перед её лицом.'
    if horny_boyB < 100:
        act 'Далее':dynamic $mitkaforestsexRelax2
    else
        act 'Смотреть дальше':dynamic $mitkaforestsexOralCum_mira2_1
    end
}
$mitkaforestsexCow_mira2_1 = {
    *clr & cla
    minut += 1
    horny += 5
    if mirasextimes < 50:horny_boyB += 20
    if mirasextimes >= 50:horny_boyB += 10
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDog_mira2_1.'+rand(1,2)+'.jpg"></center>'
    'Вы видите стоящую раком Мирославу. Она постанывает и слегка и раскачивается в такт толчков второго парня.'
    if horny_boyB >= 100:'Неожиданно парень грубо спихивает её с себя и поставив перед собой на колени, начинает дрочить перед  лицом.'
    if horny_boyB < 100:
        act 'Далее':dynamic $mitkaforestsexRelax2
    else
        act 'Смотреть дальше':dynamic $mitkaforestsexOralCum_mira2_1
    end
}
!Три парня vs ГГ и Мира
$mitkaforestsexRelax = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    temp = rand(1,3)
    hantsexa = rand(1,4)
    mitboysex += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexRelax1.'+rand(1,2)+'.jpg"></center>'
    'Вы сидите на земле, пацанам пока до вас нет дела...'
    ''
    !мира с митькой, колямбой и васькой
    mirarand = rand(1,2)
    if mirarand = 1 and mitboysex < mitboysexrand:'Недалеко от вас пацаны в три ствола трахают <a href="exec:dynamic $mitkaforestsexDP_mira3">Миру</a>.'
    if mirarand = 2 and mitboysex < mitboysexrand:'Недалеко от вас пацаны в три ствола трахают <a href="exec:dynamic $mitkaforestsexCow_mira3">Миру</a>.'
    '<<$textsexhanter7>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
    else
        act 'Смотреть на Миру':dynamic $mitkaforestsexCum_mira3
    end
}
$mitkaforestsexOral3_3 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    hantsexa = rand(1,5)
    lubonus += 1
    mitboysex += 1
    bj += 3
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexOral3.'+rand(5,6)+'.jpg"></center>'
    'Вы стоите на коленях перед пацанами, и сосете их члены, поочередно уделяю внимание каждому...'
    $boy = 'Митька' & silavag = 0 & dick = 16
    gs 'zz_dynamic_sex', 'bj'
    $boy = 'Колямба' & silavag = 0 & dick = 15
    gs 'zz_dynamic_sex', 'bj'
    $boy = 'Васян' & silavag = 0 & dick = 14
    gs 'zz_dynamic_sex', 'bj'
    ''
    !мира отдыхает
    'Недалеко от вас на земле сидит <a href="exec:dynamic $mitkaforestsexRelax_mira">Мирослава</a>.'
    ''
    '<<$textsexhanter5>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать дальше':dynamic $mitkaforestsexCum3_3
    end
}
$mitkaforestsexOral3_2 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    lubonus += 1
    temp = rand(1,3)
    hantsexa = rand(1,5)
    mitboysex += 1
    bj += 2
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexOral3.'+rand(3,4)+'.jpg"></center>'
    'Вы стоите на коленях перед пацанами, и сосете их члены, поочередно уделяю внимание каждому...'
    if temp = 1:
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
    elseif temp = 2:
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
    elseif temp = 3:
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
    end
    ''
    mirarand = rand(1,5)
    if mitboysex < mitboysexrand:
        if mirarand = 1:'Недалеко от вас слышатся причмокивающие звуки. <a href="exec:dynamic $mitkaforestsexOral_mira1">Посмотреть</a>.'
        if mirarand = 2:'Недалеко от вас слышится  сопение и хрюкающие звуки. <a href="exec:dynamic $mitkaforestsexThroat_mira1">Посмотреть</a>.'
        if mirarand = 3:'Недалеко от вас постанывает <a href="exec:dynamic $mitkaforestsexCow_mira1">Мира</a>.'
        if mirarand = 4:'Недалеко от вас постанывает <a href="exec:dynamic $mitkaforestsexDogV_mira1">Мира</a>.'
        if mirarand = 5:'Недалеко от вас громко охает <a href="exec:dynamic $mitkaforestsexDogA_mira1">Мира</a>.'
    else
        'Недалеко от вас находится <a href="exec:dynamic $mitkaforestsexCum_mira1">Мира</a>.'
    end
    ''
    '<<$textsexhanter5>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать дальше':dynamic $mitkaforestsexCum3_2
    end
}
$mitkaforestsexOral3_1 = {
    *clr & cla
    minut += 5
    horny += rand(5,10)
    lubonus += 1
    temp = rand(1,3)
    hantsexa = rand(1,5)
    mitboysex += 1
    bj += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexOral3.'+rand(1,2)+'.jpg"></center>'
    'Вы стоите на коленях перед парнем, его член перед вашим лицом...'
    if temp = 1:
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
    elseif temp = 2:
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
    elseif temp = 3:
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
    end
    !'<<$textsexhanter8>>'
    ''
    mirarand = rand(1,4)
    if mitboysex < mitboysexrand:
        if mirarand = 1:'Недалеко от вас слышится громкое мычание <a href="exec:dynamic $mitkaforestsexCow_mira2">Мирославы</a>.'
        if mirarand = 2:'Недалеко от вас слышится  возня пацанов и Миры. <a href="exec:dynamic $mitkaforestsexSide_mira2">Посмотреть</a>.'
        if mirarand = 3:'Недалеко от вас слышится сопение <a href="exec:dynamic $mitkaforestsexMis_mira2">Миры</a>.'
        if mirarand = 4:'Недалеко от вас мычание <a href="exec:dynamic $mitkaforestsexDog_mira2">Миры</a>.'
    else
        'Недалеко от вас находится <a href="exec:dynamic $mitkaforestsexCum_mira2">Мирослава</a>.'
    end
    ''
    '<<$textsexhanter4>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать дальше':dynamic $mitkaforestsexCum3_1
    end
}
$mitkaforestsexVag3 = {
    *clr & cla
    minut += 5
    lubonus += 1
    temp = rand(1,3)
    hantsexa = rand(1,5)
    mitboysex += 1
    pose = 0
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexVag3.'+rand(1,2)+'.jpg"></center>'
    'Вы лежите на земле. Один парень пристроился между ваших ног, второй подносит член к вашим губам...'
    if temp = 1:
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
        if klismaday ! day and dirty_dickA > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
        if klismaday = day  and Mira_enema = 0 and dirty_dickA > 0:'<<$textsexhanter1>>' & manna -= 5 & horny -= 20
        ''
        if boyBsex = 0: boyBsex = 1 & sex += 1
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'sex_start', 1
        gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    elseif temp = 2:
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
        if klismaday ! day and dirty_dickC > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
        if klismaday = day  and Mira_enema = 0 and dirty_dickC > 0:'<<$textsexhanter1>>' & manna -= 5 & horny -= 20
        ''
        if boyAsex = 0: boyAsex = 1 & sex += 1
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'sex_start', 1
        gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    elseif temp = 3:
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
        if klismaday ! day and dirty_dickB > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
        if klismaday = day  and Mira_enema = 0 and dirty_dickB > 0:'<<$textsexhanter1>>' & manna -= 5 & horny -= 20
        ''
        if boyCsex = 0: boyCsex = 1 & sex += 1
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'sex_start', 1
        gs 'zz_dynamic_sex', 'vaginal', 'dick', 1
    end
    ''
    mirarand = rand(1,5)
    if mitboysex < mitboysexrand:
        if mirarand = 1:'Недалеко от вас слышатся причмокивающие звуки. <a href="exec:dynamic $mitkaforestsexOral_mira1">Посмотреть</a>.'
        if mirarand = 2:'Недалеко от вас слышится  сопение и хрюкающие звуки. <a href="exec:dynamic $mitkaforestsexThroat_mira1">Посмотреть</a>.'
        if mirarand = 3:'Недалеко от вас постанывает <a href="exec:dynamic $mitkaforestsexCow_mira1">Мира</a>.'
        if mirarand = 4:'Недалеко от вас постанывает <a href="exec:dynamic $mitkaforestsexDogV_mira1">Мира</a>.'
        if mirarand = 5:'Недалеко от вас громко охает <a href="exec:dynamic $mitkaforestsexDogA_mira1">Мира</a>.'
    else
        'Недалеко от вас находится <a href="exec:dynamic $mitkaforestsexCum_mira1">Мира</a>.'
    end
    ''
    '<<$textsexhanter5>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Стать на колени':dynamic $mitkaforestsexCum3_2
    end
}
$mitkaforestsexAnal3_3 = {
    *clr & cla
    minut += 5
    temp = rand(1,3)
    hantsexa = rand(1,5)
    mitboysex += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexAnal3.'+rand(5,6)+'.jpg"></center>'
    'Вы стоите раком перед пацанами. Один пристраевается к вашей попке, двое других вывалили члены перед вашим лицом...'
    '<<$textsexhanter5>>'
    if temp = 1:
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
        if klismaday ! day and dirty_dickC > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
        if klismaday = day  and Mira_enema = 0 and dirty_dickC > 0:'<<$textsexhanter1>>' & manna -= 5 & horny -= 20
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
        if klismaday ! day and dirty_dickA > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
        if klismaday = day  and Mira_enema = 0 and dirty_dickA > 0:'<<$textsexhanter1>>' & manna -= 5 & horny -= 20
        ''
        if boyBsexa = 0: boyBsexa = 1 & anal += 1
        $boy = 'Колямба' & silavag = 0 & dick = 15 & dirty_dickB += 1
        gs 'zz_dynamic_sex', 'anal_start', 'dick'
        gs 'zz_dynamic_sex', 'anal', 'dick', 1
    elseif temp = 2:
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
        if klismaday ! day and dirty_dickB > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
        if klismaday = day  and Mira_enema = 0 and dirty_dickB > 0:'<<$textsexhanter1>>' & manna -= 5 & horny -= 20
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
        if klismaday ! day and dirty_dickC > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
        if klismaday = day  and Mira_enema = 0 and dirty_dickC > 0:'<<$textsexhanter1>>' & manna -= 5 & horny -= 20
        ''
        if boyAsexa = 0: boyAsexa = 1 & anal += 1
        $boy = 'Митька' & silavag = 0 & dick = 16 & dirty_dickA += 1
        gs 'zz_dynamic_sex', 'anal_start', 'dick'
        gs 'zz_dynamic_sex', 'anal', 'dick', 1
    elseif temp = 3:
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
        if klismaday ! day and dirty_dickA > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
        if klismaday = day  and Mira_enema = 0 and dirty_dickA > 0:'<<$textsexhanter1>>' & manna -= 5 & horny -= 20
        $boy = 'Колямба' & silavag = 0 & dick = 15
        if klismaday ! day and dirty_dickB > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
        if klismaday = day  and Mira_enema = 0 and dirty_dickB > 0:'<<$textsexhanter1>>' & manna -= 5 & horny -= 20
        gs 'zz_dynamic_sex', 'bj'
        ''
        if boyCsexa = 0: boyCsexa = 1 & anal += 1
        $boy = 'Васян' & silavag = 0 & dick = 14 & dirty_dickC += 1
        gs 'zz_dynamic_sex', 'anal_start', 'dick'
        gs 'zz_dynamic_sex', 'anal', 'dick', 1
    end
    ''
    !мира отдыхает
    'Недалеко от вас на земле сидит <a href="exec:dynamic $mitkaforestsexRelax_mira">Мирослава</a>.'
    ''
    '<<$textsexhanter7>>'
    lubonus += 1
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Стать на колени':dynamic $mitkaforestsexCum3_3
    end
}
$mitkaforestsexAnal3_2 = {
    *clr & cla
    minut += 5
    temp = rand(1,3)
    hantsexa = rand(1,5)
    mitboysex += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexAnal3.'+rand(3,4)+'.jpg"></center>'
    'Вы стоите раком перед пацанами. Один из них пристраивается к попе, второй подносит член к вашим губам...'
    if temp = 1:
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
        if klismaday ! day and dirty_dickA > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
        if klismaday = day  and Mira_enema = 0 and dirty_dickA > 0:'<<$textsexhanter1>>' & manna -= 5 & horny -= 20
        ''
        if boyBsexa = 0: boyBsexa = 1 & anal += 1
        $boy = 'Колямба' & silavag = 0 & dick = 15 & dirty_dickB += 1
        gs 'zz_dynamic_sex', 'anal_start', 'dick'
        gs 'zz_dynamic_sex', 'anal', 'dick', 1
    elseif temp = 2:
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
        if klismaday ! day and dirty_dickC > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
        if klismaday = day  and Mira_enema = 0 and dirty_dickC > 0:'<<$textsexhanter1>>' & manna -= 5 & horny -= 20
        ''
        if boyAsexa = 0: boyAsexa = 1 & anal += 1
        $boy = 'Митька' & silavag = 0 & dick = 16 & dirty_dickA += 1
        gs 'zz_dynamic_sex', 'anal_start', 'dick'
        gs 'zz_dynamic_sex', 'anal', 'dick', 1
    elseif temp = 3:
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
        if klismaday ! day and dirty_dickB > 0:'<<$textsexhanter>>' & manna -= 5 & horny -= 20
        if klismaday = day  and Mira_enema = 0 and dirty_dickB > 0:'<<$textsexhanter1>>' & manna -= 5 & horny -= 20
        ''
        if boyCsexa = 0: boyCsexa = 1 & anal += 1
        $boy = 'Васян' & silavag = 0 & dick = 14 & dirty_dickC += 1
        gs 'zz_dynamic_sex', 'anal_start', 'dick'
        gs 'zz_dynamic_sex', 'anal', 'dick', 1
    end
    ''
    lubonus += 1
    mirarand = rand(1,5)
    if mitboysex < mitboysexrand:
        if mirarand = 1:'Недалеко от вас слышатся причмокивающие звуки. <a href="exec:dynamic $mitkaforestsexOral_mira1">Посмотреть</a>.'
        if mirarand = 2:'Недалеко от вас слышится  сопение и хрюкающие звуки. <a href="exec:dynamic $mitkaforestsexThroat_mira1">Посмотреть</a>.'
        if mirarand = 3:'Недалеко от вас постанывает <a href="exec:dynamic $mitkaforestsexCow_mira1">Мира</a>.'
        if mirarand = 4:'Недалеко от вас постанывает <a href="exec:dynamic $mitkaforestsexDogV_mira1">Мира</a>.'
        if mirarand = 5:'Недалеко от вас громко охает <a href="exec:dynamic $mitkaforestsexDogA_mira1">Мира</a>.'
    else
        'Недалеко от вас находится <a href="exec:dynamic $mitkaforestsexCum_mira1">Мира</a>.'
    end
    ''
    '<<$textsexhanter5>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Стать на колени':dynamic $mitkaforestsexCum3_2
    end
}
$mitkaforestsexAnal3_1 = {
    *clr & cla
    minut += 5
    temp = rand(1,3)
    hantsexa = rand(1,5)
    mitboysex += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexAnal3.'+rand(1,2)+'.jpg"></center>'
    'Вы стоите раком перед парнем, он пристаивается сзади...'
    if temp = 1:
        if boyAsexa = 0: boyAsexa = 1 & anal += 1
        $boy = 'Митька' & silavag = 0 & dick = 16 & dirty_dickA += 1
        gs 'zz_dynamic_sex', 'anal_start', 'dick'
        gs 'zz_dynamic_sex', 'anal', 'dick', 1
    elseif temp = 2:
        if boyBsexa = 0: boyBsexa = 1 & anal += 1
        $boy = 'Колямба' & silavag = 0 & dick = 15 & dirty_dickB += 1
        gs 'zz_dynamic_sex', 'anal_start', 'dick'
        gs 'zz_dynamic_sex', 'anal', 'dick', 1
    elseif temp = 3:
        if boyCsexa = 0: boyCsexa = 1 & anal += 1
        $boy = 'Васян' & silavag = 0 & dick = 14 & dirty_dickC += 1
        gs 'zz_dynamic_sex', 'anal_start', 'dick'
        gs 'zz_dynamic_sex', 'anal', 'dick', 1
    end
    !'<<$textsexhanter8>>'
    ''
    mirarand = rand(1,4)
    if mitboysex < mitboysexrand:
        if mirarand = 1:'Недалеко от вас слышится громкое мычание <a href="exec:dynamic $mitkaforestsexCow_mira2">Мирославы</a>.'
        if mirarand = 2:'Недалеко от вас слышится  возня пацанов и Миры. <a href="exec:dynamic $mitkaforestsexSide_mira2">Посмотреть</a>.'
        if mirarand = 3:'Недалеко от вас слышится сопение <a href="exec:dynamic $mitkaforestsexMis_mira2">Миры</a>.'
        if mirarand = 4:'Недалеко от вас мычание <a href="exec:dynamic $mitkaforestsexDog_mira2">Миры</a>.'
    else
        'Недалеко от вас находится <a href="exec:dynamic $mitkaforestsexCum_mira2">Мирослава</a>.'
    end
    ''
    '<<$textsexhanter4>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Стать на колени':dynamic $mitkaforestsexCum3_1
    end
}
$mitkaforestsexCum3_3 = {
    *clr & cla
    minut += 3
    gs 'zz_funcs', 'cum', 'lip'
	swallow += 1
    gs 'zz_funcs', 'cum', 'face'
    vaf += 1
	if current_clothing = 0:gs 'zz_funcs', 'cum', 'belly'
	if current_clothing > 2:cumfrot += rand(0,1)
    mitboysex = 0
    protect = 0
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCum3.3.jpg"></center>'
    'Вы стоите на коленях перед пацанами, и сосете их члены, поочередно уделяю внимание каждому...'
    $boy = 'Митька' & silavag = 0 & dick = 16
    gs 'zz_dynamic_sex', 'bj'
    $boy = 'Колямба' & silavag = 0 & dick = 15
    gs 'zz_dynamic_sex', 'bj'
    $boy = 'Васян' & silavag = 0 & dick = 14
    gs 'zz_dynamic_sex', 'bj'
    !'<<$textsexhanter9>>'
    'Вскоре не выдержав вашего напора парни начинают кончать. Струи спермы ударяют вам в рот и попадают на лицо, одна, вторая, третья. Спермы оказалось слишком много. Она стекает по подбородку, капая вниз. Парни убрали члены в штаны и пошели по своим делам, оставив вас с Мирой приводить себя в порядок.'
    act 'Далее':gt $loc, $metka
}
$mitkaforestsexCum3_2 = {
    *clr & cla
    minut += 2
    gs 'zz_funcs', 'cum', 'lip'
	swallow += 1
    gs 'zz_funcs', 'cum', 'face'
    vaf += 1
	if current_clothing = 0:gs 'zz_funcs', 'cum', 'belly'
	if current_clothing > 2:cumfrot += rand(0,1)
    mitboysex = 0
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCum3.2.jpg"></center>'
    'Вы стоите на коленях перед пацанами, и сосете их члены, поочередно уделяю внимание каждому...'
    if temp = 1:
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
    elseif temp = 2:
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
    elseif temp = 3:
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
    end
    ''
    'Вскоре не выдержав вашего напора парни начинают кончать. Струи спермы ударяют вам в рот и попадают на лицо, одна, вторая, третья. Спермы оказалось слишком много. Она стекает по подбородку, капая вниз. Парни убрали члены в штаны и пошели по своим делам, оставив вас с Мирой приводить себя в порядок.'
    act 'Далее':gt $loc, $metka
}
$mitkaforestsexCum3_1 = {
    *clr & cla
    minut += 1
    mitboysex = 0
    protect = 0
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCum3.1.jpg"></center>'
    'Вы стоите на коленях перед парнем, его член перед вашим лицом...'
    if temp = 1:
        $boy = 'Митька' & silavag = 0 & dick = 16
        gs 'zz_dynamic_sex', 'bj'
        !'<<$textsexhanter8>>'
        gs 'zz_dynamic_sex', 'swallow'
    elseif temp = 2:
        $boy = 'Колямба' & silavag = 0 & dick = 15
        gs 'zz_dynamic_sex', 'bj'
        !'<<$textsexhanter8>>'
        gs 'zz_dynamic_sex', 'swallow'
    elseif temp = 3:
        $boy = 'Васян' & silavag = 0 & dick = 14
        gs 'zz_dynamic_sex', 'bj'
        !'<<$textsexhanter8>>'
        gs 'zz_dynamic_sex', 'swallow'
    end
    '<<$textsexhanter3>>'
    act 'Далее':gt $loc, $metka
}
$mitkaforestsexRelax_mira = {
    *clr & cla
    minut += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexRelax_mira'+rand(1,2)+'.jpg"></center>'
    'Мира сидит рядом и пока пацанам не до неё, смотрит на как вас трахают...'
    ''
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать':dynamic $mitkaforestsexCum3_3
    end
}
$mitkaforestsexDP_mira3 = {
    *clr & cla
    minut += 1
    horny += rand(20,30)
    lubonus += 1
    mirarand = rand(1,3)
    if mirarand = 1:dirty_dickA += 1
    if mirarand = 2:dirty_dickB += 1
    if mirarand = 3:dirty_dickC += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDP_mira3.jpg"></center>'
    'Вы с интересом наблюдаете как Миру пацаны натягивают Миру сразу на три члена, заполняя все её дырочки. Мире остается только мычать и напряженно сопеть.'
    '<<$textsexhanter7>>'
    if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
    if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
    if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
    if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
}
$mitkaforestsexCow_mira3 = {
    *clr & cla
    minut += 1
    horny += 5
    lubonus += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCow_mira3.jpg"></center>'
    'Вы смотрите как Мира, громко мыча, скачет на члене одного пацана, а двоих других, поочередно, обслуживает ртом.'
    '<<$textsexhanter7>>'
    if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
    if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
    if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
    if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
}
$mitkaforestsexCow_mira2 = {
    *clr & cla
    minut += 1
    horny += 5
    lubonus += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCow_mira2.'+rand(1,3)+'.jpg"></center>'
    'Повернув голову в сторону Миры, вы видите как она, громко мыча, скачет на члене одного пацана, одновременно сося член второго.'
    '<<$textsexhanter4>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать':dynamic $mitkaforestsexCum3_1
    end
}
$mitkaforestsexSide_mira2 = {
    *clr & cla
    minut += 1
    horny += 5
    lubonus += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexSide_mira2.jpg"></center>'
    'Повернув голову в сторону Миры, вы видите как её, лежащую на боку, трахает один из парней, пока она сосет второму.'
    '<<$textsexhanter4>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать':dynamic $mitkaforestsexCum3_1
    end
}
$mitkaforestsexMis_mira2 = {
    *clr & cla
    minut += 1
    horny += 5
    lubonus += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexMis_mira2.jpg"></center>'
    'Повернув голову в сторону Миры, вы видите как её, лежащую на спине, трахает один из парней, пока она сосет второму.'
    '<<$textsexhanter4>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать':dynamic $mitkaforestsexCum3_1
    end
}
$mitkaforestsexDog_mira2 = {
    *clr & cla
    minut += 1
    horny += 5
    lubonus += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDog_mira2.jpg"></center>'
    'Повернув голову в сторону Миры, вы видите как её, стоящую раком, обступили парни и трахают с двух сторон одновременно.'
    '<<$textsexhanter4>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать':dynamic $mitkaforestsexCum3_1
    end
}
$mitkaforestsexCow_mira1 = {
    *clr & cla
    minut += 1
    horny += 5
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCow_mira1.jpg"></center>'
    'Скосив взгляд в сторону, вы видите Мирославу, которая постанывая, скачет на члене парня.'
    '<<$textsexhanter5>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать':dynamic $mitkaforestsexCum3_2
    end
}
$mitkaforestsexDogV_mira1 = {
    *clr & cla
    minut += 1
    horny += 5
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDogV_mira1.jpg"></center>'
    'Скосив взгляд в сторону, вы видите Мирославу, которая постанывает стоя раком, пока парень размашисто долбит её киску.'
    '<<$textsexhanter5>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать':dynamic $mitkaforestsexCum3_2
    end
}
$mitkaforestsexDogA_mira1 = {
    *clr & cla
    minut += 1
    horny += 5
    mirarand = rand(1,3)
    if mirarand = 1:dirty_dickA += 1
    if mirarand = 2:dirty_dickB += 1
    if mirarand = 3:dirty_dickC += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexDogA_mira1.jpg"></center>'
    'Скосив взгляд в сторону, вы видите Мирославу, которая громко охает стоя раком, когда парень, пристроившийся сзади, таранит её зад своим членом.'
    '<<$textsexhanter5>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать':dynamic $mitkaforestsexCum3_2
    end
}
$mitkaforestsexThroat_mira1 = {
    *clr & cla
    minut += 1
    horny += 5
    lubonus += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexThroat_mira1.jpg"></center>'
    'Скосив взгляд в сторону, парня, который запрокинув голову сопящей и хрюкающей Миры, долбит её прямо в горло.'
    '<<$textsexhanter5>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать':dynamic $mitkaforestsexCum3_2
    end
}
$mitkaforestsexOral_mira1 = {
    *clr & cla
    minut += 1
    horny += 5
    lubonus += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexOral_mira1.jpg"></center>'
    'Скосив взгляд в сторону, вы видите Мирославу, усердно отсасывающую парню.'
    '<<$textsexhanter5>>'
    if mitboysex < mitboysexrand:
        if hantsexa = 1:act 'Лечь на спину':dynamic $mitkaforestsexVag3
        if hantsexa = 2:act 'Стать раком':dynamic $mitkaforestsexAnal3_1
        if hantsexa = 3:act 'Стать раком':dynamic $mitkaforestsexAnal3_2
        if hantsexa = 4:act 'Стать раком':dynamic $mitkaforestsexAnal3_3
        if hantsexa = 5:act 'Смотреть':dynamic $mitkaforestsexRelax
    else
        act 'Сосать':dynamic $mitkaforestsexCum3_2
    end
}
$mitkaforestsexCum_mira1 = {
    *clr & cla
    minut += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCum_mira1.jpg"></center>'
    'Скосив взгляд в сторону, вы видите лежащую на земле Мирославу, лицо которой все залито спермой, и стоящего над ней парня.'
    '<<$textsexhanter5>>'
    act 'Сосать':dynamic $mitkaforestsexCum3_2
}
$mitkaforestsexCum_mira2 = {
    *clr & cla
    minut += 1
    gs'stat'
    '<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCum_mira2.jpg"></center>'
    'Скосив взгляд в сторону, вы видите лежащую на земле Мирославу, и кончающих ей на лицо пацанов.'
    '<<$textsexhanter4>>'
    act 'Сосать':dynamic $mitkaforestsexCum3_2
}
$mitkaforestsexCum_mira3 = {
    *clr & cla
	minut += 1
	gs'stat'
	'<center><img src="images/qwest/gadukino/mitkasex/mitkaforestsexCum_mira3.jpg"></center>'
	'Вы видите, пацанов обступивших со всех сторонстоящую на коленях Миру, лицо которой покрыто толстым слоем спермы.'
	act 'Далее':gt $loc, $metka
}
$textsexhanter = 'От члена неприятно пахнет и во рту остается мерзкий привкус фекалий. "-Блин, надо было сделать клизму." - запоздало думаеете вы.'
$textsexhanter1 = 'От члена неприятно пахнет и во рту остается мерзкий привкус фекалий. "-Блин, клизму надо делать, дура!!!" - кидаете вы на Миру яростные взгляды.'
$textsexhanter2 = 'Он смотрит вам в лицо пока ваши губы скользят по его напряженному члену. Прервав вас, парень говорит...'
$textsexhanter3 = 'Он кончил и ушел с довольной улыбкой на лице, а вы остались приводить себя в порядок...'
$textsexhanter4 = 'Вдоволь насладившись в этой позе, парень говорит...'
$textsexhanter5 = 'Парни смотрят вам в лицо пока ваши губы скользят по их напряженным членам. Прервав вас, они говорят...'
$textsexhanter6 = 'Он кончил и отошел в сторону с довольной улыбкой на лице, а вы остались продолжать со вторым парнем...'
$textsexhanter7 = 'Вдоволь насладившись в этой позе, парни говорят...'
$textsexhanter8 = 'Он смотрит вам в лицо пока ваши губы скользят по его напряженному члену...'
$textsexhanter9 = 'Парни смотрят вам в лицо пока ваши губы скользят по их напряженным членам...'
$textsexhanter10 = 'Он кончил и отошел в сторону с довольной улыбкой на лице, а вы остались с Мирой приводить себя в порядок...'
$textsexhanter11 = 'Постепенно приятное тепло и пульсация нарастают внизу живота, потом ощущения обрушиваются на вас и все ваше тело охватывают горячие волны оргазма.'
$textsexhanter12 = 'Вам становится приятно когда <<dick>> сантиметровый член движется внутри вашей попки и вы стонете от удовольствия. Постепенно приятное тепло и пульсация нарастают внизу живота, потом ощущения обрушиваются на вас и все ваше тело охватывают горячие волны оргазма.'