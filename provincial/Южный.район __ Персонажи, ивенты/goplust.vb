GLust = 0
VasanLust = RAND(0,100)
if VasanLust >= 50 and VasanTut = 1:
	VasanTut = 2
	GLust += 1
	$gopV = 'Васян Гвоздь смотрит на вас алчным взглядом'
elseif VasanLust < 80 and VasanTut = 1:
	$gopV = 'Васян Гвоздь смотрит на вас равнодушно'
elseif VasanTut = 0:
	$gopV = ''
end
BerezaLust = RAND(0,100)
if BerezaLust >= 60 and BerezaTut = 1:
	BerezaTut = 2
	GLust += 1
	$gopB = 'Береза с интересом разглядывает вас'
elseif BerezaLust < 95 and BerezaTut = 1:
	$gopB = 'Береза не смотрит на вас'
elseif BerezaTut = 0:
	$gopB = ''
end
VitekLust = RAND(0,100)
if VitekLust >= 60 and VitekTut = 1:
	VitekTut = 2
	GLust += 1
	$gopVi = 'Витек на сводит взгляда с вашей груди'
elseif VitekLust < 90 and VitekTut = 1:
	$gopVi = 'Витек копается в телефоне'
elseif VitekTut = 0:
	$gopVi = ''
end
KotilLust = RAND(0,100)
if KotilLust >= 70 and KostilTut = 1:
	KostilTut = 2
	GLust += 1
	$gopK = 'Костыль обшаривает вашу фигуру плотоядным взглядом'
elseif KotilLust < 90 and KostilTut = 1:
	$gopK = 'Костыль щелыкает семки'
elseif KostilTut = 0:
	$gopK = ''
end
UdmurtLust = RAND(0,100)
if UdmurtLust >= 80 and UdmurtTut = 1:
	UdmurtTut = 2
	GLust += 1
	$gopU = 'Удмурт тяжелым взглядом уставился на вас и вы видите как у него в штанах, между ног вырастает выпуклость.'
elseif UdmurtLust < 90 and UdmurtTut = 1:
	$gopU = 'Удмурт сидит на корточках и плюет на асфальт'
elseif UdmurtTut = 0:
	$gopU = ''
end
SeriLust = RAND(0,100)
if SeriLust >= 90 and SeriTut = 1:
	SeriTut = 2
	GLust += 1
	$gopS = 'Серый сплевывает на асфальт через свои золотые зубы и ехидно оскалившись пялится на ваши ноги.'
elseif SeriLust < 95 and SeriTut = 1:
	$gopS = 'Серый отвернулся и разговаривает по телефону'
elseif SeriTut = 0:
	$gopS = ''
end
$gopnik = '<<$gopV>> <<$gopB>> <<$gopVi>> <<$gopK>> <<$gopU>> <<$gopS>>'